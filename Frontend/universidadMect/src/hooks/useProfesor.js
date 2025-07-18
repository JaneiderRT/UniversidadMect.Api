import { useQuery } from "@tanstack/react-query";
import { getProfesorMaterias, getProfesores } from "../api/profesorAPI";

export const useProfesores = () => {
    return useQuery({
        queryKey: ["profesores"],
        queryFn: getProfesores
    })
}

export const useProfesorMaterias = (idProfesor) => {
    return useQuery({
        queryKey: ["profesor", idProfesor],
        queryFn: getProfesorMaterias
    })
}