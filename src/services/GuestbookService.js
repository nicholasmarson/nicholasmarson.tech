import axios from 'axios';

const http = axios.create({
    baseURL: 'http://localhost:5226/api/Guestbook',
});
export default {
    getGuestbookEntries() {
        return http.get('');
    },
    addGuestbookEntry(entry) {
        return http.post('', entry);
    },
}