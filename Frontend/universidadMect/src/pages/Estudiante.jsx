import { useParams } from "react-router-dom"
import EstudianteDetalle from "../features/EstudianteDetalle"

export default function Universidad() {
    const params = useParams()

    return(
        <article>
            <h1>Estudiante {params.id}</h1>
            <EstudianteDetalle idEstudiante={params.id}/>
        </article>
    )
}