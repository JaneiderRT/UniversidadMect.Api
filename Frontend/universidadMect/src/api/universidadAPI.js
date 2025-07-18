import instanciaAxios from "./instanciaAxios";

const pathGeneral = "/Universidad"

export const getUniversidad = async ({ queryKey }) => {
    const [, idUniversidad] = queryKey;
    const respuesta = await instanciaAxios.get(`${pathGeneral}/ConsultarUniversidadPorId?id=${idUniversidad}`)
    return respuesta.data
}