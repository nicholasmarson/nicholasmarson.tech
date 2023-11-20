import { createRouter, createWebHashHistory } from 'vue-router'

const routes = [
  {
    path: '/',
    name: 'home',
    component: () => import('../views/HomeView.vue')
  },
  {
    path: '/about',
    name: 'about',
    component: () => import('../views/AboutView.vue')
  },
  {
    path: '/resume',
    name: 'resume',
    component: () => import('../views/ResumeView.vue')
  },
  {
    path: '/guestbookform',
    name: 'guestbookform',
    component: () => import('../views/GuestbookFormView.vue')
  },
  {
    path: '/guestbookentries',
    name: 'guestbookentries',
    component: () => import('../views/GuestbookEntriesView.vue')
  },
  {
    path: '/:catchAll(.*)',
    redirect: { name: 'home' }
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router