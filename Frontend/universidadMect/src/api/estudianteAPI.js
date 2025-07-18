import instanciaAxios from "./instanciaAxios";

const pathGeneral = "/Estudiante"

export const getEstudiante = async ({ queryKey }) => {
    const [, idEstudiante] = queryKey
    const respuesta = await instanciaAxios.get(`${pathGeneral}/ConsultarEstudiantePorId?id=${idEstudiante}`)
    return respuesta.data
}

export const getEstudiantes = async () => {
    const respuesta = await instanciaAxios.get(`${pathGeneral}/ConsultarEstudiantes`)
    return respuesta.data
}

export const getEstudianteInscripcion = async ({ queryKey }) => {
    const [, idEstudiante] = queryKey
    const respuesta = await instanciaAxios.get(`${pathGeneral}/ConsultarEstudianteInscripcionPorId?id=${idEstudiante}`)
    return respuesta.data
}

export const getEstudiantesInscripcion = async () => {
    const respuesta = await instanciaAxios.get(`${pathGeneral}/ConsultarEstudiantesInscripcion`)
    return respuesta.data
}

export const putEstudiante = async (estudianteData) => {
    const respuesta = await instanciaAxios.put(`${pathGeneral}/ActualizarEstudiante`, estudianteData)
    return respuesta.data
}