import instanciaAxios from "./instanciaAxios";

const pathGeneral = "/Materia"

export const getMaterias = async () => {
    const respuesta = await instanciaAxios.get(`${pathGeneral}/ConsultarMaterias`)
    return respuesta.data
}