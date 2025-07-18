import instanciaAxios from "./instanciaAxios";

const pathGeneral = "/Profesor"

export const getProfesores = async () => {
    const respuesta = await instanciaAxios.get(`${pathGeneral}/ConsultarProfesores`)
    return respuesta.data
}

export const getProfesorMaterias = async ({ queryKey }) => {
    const [, idProfesor] = queryKey
    const respuesta = await instanciaAxios.get(`${pathGeneral}/ConsultarProfesorMateriasPorId?id=${idProfesor}`)
    return respuesta.data
}