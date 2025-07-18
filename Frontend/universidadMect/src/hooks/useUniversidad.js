import { useQuery } from "@tanstack/react-query"
import { getUniversidad } from "../api/universidadAPI"

export const useUniversidad = (idUniversidad) => {
    return useQuery({
        queryKey: ["universidad", idUniversidad],
        queryFn: getUniversidad,
    })
}