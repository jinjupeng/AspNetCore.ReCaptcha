<template>
  <!-- 添加一个 div 用作容器 -->
  <div id="grecaptcha"></div>
</template>
<script>
import axios from 'axios'
export default {
  data () {
    return {
      sitekey: '6LchMQMdAAAAACBluHeqgYW6O6FGi3G0Whll1Os4'
    }
  },
  methods: {
    submit: function (token) {
      console.log(token)
      axios
        .get('api/recaptcha/login', {
          params: {
            token: token
          }
        })
        .then(function (response) {
          console.log(response)
        })
        .catch(function (error) {
          console.log(error)
        })
    },
    loaded () {
      setTimeout(() => {
        window.grecaptcha.render('grecaptcha', {
          sitekey: this.sitekey,
          callback: this.submit
        })
      }, 2000)
    }
  },
  mounted () {
    this.loaded()
  }
}
</script>
