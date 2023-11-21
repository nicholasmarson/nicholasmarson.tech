import axios from 'axios';

const http = axios.create({
    baseURL: 'http://localhost:5004/api',
});
export default {
    fetchGuestbooks() {
        return http.get('/guestbooks');
    },
    addGuestbook(entry) {
        return http.post('/guestbooks', entry);
    },
}