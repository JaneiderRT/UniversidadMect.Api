import { useParams } from "react-router-dom"
import EstudianteInscripcionList from "../features/EstudianteInscripcionList"

export default function EstudianteInscripcion() {
    const params = useParams()

    return(
        <section>
            <h1>Inscripciones Del Estudiante {params.id}</h1>
            <EstudianteInscripcionList idEstudiante={params.id}/>
        </section>
    )
}