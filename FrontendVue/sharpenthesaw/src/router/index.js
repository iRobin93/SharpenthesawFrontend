import { createRouter, createWebHistory } from 'vue-router'
import DefaultView from '../views/DefaultView.vue'
import BlacksmithView from '@/views/BlacksmithView.vue'


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
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
