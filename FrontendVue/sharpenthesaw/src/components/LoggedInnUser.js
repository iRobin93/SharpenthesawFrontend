import { createStore } from 'vuex'

export default createStore({
  state: {
    loggedInn: {
      id: '',
      name: '',
      role: '',
      lifePoints: '',
      weedstones: ''
    }
  },
  mutations: {
    setLoggedInn(state, payload) {
      state.loggedInn = payload
    },
    updateLoggedInnField(state, { key, value }) {
      state.loggedInn[key] = value
    }
  },
  actions: {
    setLoggedInn({ commit }, payload) {
      commit('setLoggedInn', payload)
    },
    updateLoggedInnField({ commit }, payload) {
      commit('updateLoggedInnField', payload)
    }
  },
  getters: {
    loggedInn: (state) => state.loggedInn
  }
})