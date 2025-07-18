import { useQuery } from "@tanstack/react-query";
import { getProgramas, getProgramasUniversidad } from "../api/programaAPI";

export const useProgramas = () => {
    return useQuery({
        queryKey: ["programas"],
        queryFn: getProgramas
    })
}

export const useProgramasUniversidad = (idUniversidad) => {
    return useQuery({
        queryKey: ["programasUniversidad", idUniversidad],
        queryFn: getProgramasUniversidad
    })
}