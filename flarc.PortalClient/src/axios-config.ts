import axios from 'axios';

const instance = axios.create({
    baseURL: import.meta.env.VITE_API_BASE_URL,
});

instance.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem("token");
    config.headers.Authorization = `Bearer ${token}`;
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

export default instance;