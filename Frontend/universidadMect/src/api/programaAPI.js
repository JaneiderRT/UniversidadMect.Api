import instanciaAxios from "./instanciaAxios";

const pathGeneral = "/Programa"

export const getProgramas = async () => {
    const respuesta = await instanciaAxios.get(`${pathGeneral}/ConsultarProgramas`)
    return respuesta.data
}

export const getProgramasUniversidad = async ({ queryKey }) => {
    const [, idUniversidad] = queryKey
    const respuesta = await instanciaAxios.get(`${pathGeneral}/ConsultarProgramasPorUniversidad?universidadId=${idUniversidad}`)
    return respuesta.data
}