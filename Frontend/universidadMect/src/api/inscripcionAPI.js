import instanciaAxios from "./instanciaAxios";

const pathGeneral = "/Inscripcion"

export const postInscripcion = async (inscripcionData) => {
    const respuesta = await instanciaAxios.post(`${pathGeneral}/InsertarInscripcion`, inscripcionData)
    return respuesta.data
}