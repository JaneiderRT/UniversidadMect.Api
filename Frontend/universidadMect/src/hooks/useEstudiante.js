import { useQuery, useMutation } from "@tanstack/react-query";
import { 
    getEstudiante, 
    getEstudiantes, 
    getEstudianteInscripcion, 
    getEstudiantesInscripcion,
    putEstudiante
} from "../api/estudianteAPI";

export const useEstudiante = (idEstudiante) => {
    return useQuery({
        queryKey: ["estudiante", idEstudiante],
        queryFn: getEstudiante
    })
}

export const useEstudiantes = () => {
    return useQuery({
        queryKey: ["estudiantes"],
        queryFn: getEstudiantes
    })
}

export const useEstudianteInscripcion = (idEstudiante) => {
    return useQuery({
        queryKey: ["estudianteInscripcion", idEstudiante],
        queryFn: getEstudianteInscripcion
    })
}

export const useEstudiantesInscripcion = () => {
    return useQuery({
        queryKey: ["estudiantesInscripcion"],
        queryFn: getEstudiantesInscripcion
    })
}

export const usePutEstudiante = () => {
    return useMutation({
        mutationFn: putEstudiante
    })
}