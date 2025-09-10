import { createRouter, createWebHistory } from 'vue-router'
import DefaultView from '../views/DefaultView.vue'
import BlacksmithView from '@/views/BlacksmithView.vue'
import NeedBoostView from  '@/views/NeedBoostView.vue'
import TargetView from '@/views/TargetView.vue'
import AddTargetView from '@/views/AddTargetView.vue'
import UsersView from '@/views/UsersView.vue'


const routes = [
  {
    path: '/',
    name: 'default',
    component: DefaultView
  },
  {
    path: '/blacksmith',
    name: 'about',
    component: BlacksmithView
  },
  {
    path: '/needsomeboost',
    name: 'needboost',
    component: NeedBoostView
  },
  {
    path: '/target',
    name: 'target',
    component: TargetView
  },
  {
    path: '/addtarget',
    name: 'addtarget',
    component: AddTargetView
  },
  { path: '/users', // added by Andrew to test...
    name: 'users', 
    component: UsersView 
  },

]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
