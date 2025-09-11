<template>
        <form @submit.prevent="Login" class="form"> 
            <label>Username:
                <input required v-model="formInputs.name">
            </label>
            
            <br>
            <label>Password:
                <input type="password" required v-model="formInputs.password"></input>
            </label>
            <br>
            <div class="submit">
            <button>Log inn</button>
            </div>
        </form>
</template>

<script>
import { http } from '../api/http';
import { mapState } from 'vuex'
import { useStore } from 'vuex'

const store = useStore()


export default {
    data() {
          return {
            formInputs: {
                id: 0,
                name: '',
                email: '',
                password: '',
                role: '',
                lifepoints: 0,
                weedstones: 0
            },
          };
      },
      computed: {
        ...mapState(['loggedInn'])
      },
      created () {
      },
      methods: {
        async Login() {
    const res = await http.post('/login', this.formInputs);
    let data = res.data;
    this.updateName(data.userId)
    return false

        },
        updateName(id) {
  this.$store.commit('updateLoggedInnField', { key: 'id', value: id })
}

      }
    }  
</script>
