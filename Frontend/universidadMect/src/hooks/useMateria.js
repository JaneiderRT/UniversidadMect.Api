import { useQuery } from "@tanstack/react-query";
import { getMaterias } from "../api/materiaAPI";

export const useMateria = () => {
    return useQuery({
        queryKey: ["materias"],
        queryFn: getMaterias
    })
}