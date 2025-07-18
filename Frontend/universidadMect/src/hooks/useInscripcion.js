import { useMutation } from "@tanstack/react-query";
import { postInscripcion } from "../api/inscripcionAPI";

export const useInscripcion = () => {
    return useMutation({
        mutationFn: postInscripcion
    })
}