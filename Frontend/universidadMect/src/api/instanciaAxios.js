import axios from "axios";

const instanciaAxios = axios.create({
  baseURL: "http://localhost:5037/api",
  headers: {
    "Content-Type": "application/json",
  },
});

// Interceptores (opcional: para manejar tokens o errores globales)
instanciaAxios.interceptors.response.use(
  (response) => response,
  (error) => {
    console.error("API Error:", error.response || error.message);
    return Promise.reject(error);
  }
);

export default instanciaAxios;