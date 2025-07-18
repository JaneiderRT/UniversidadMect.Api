import { useParams } from "react-router-dom"
import ProgramaUniversidadList from "../features/ProgramaUniversidadList"

export default function ProgramaUniversidad() {
    const param = useParams()

    return(
        <article>
            <h1>Programas De La Universidad {param.id}</h1>
            <ProgramaUniversidadList idUniversidad={param.id}/>
        </article>
    )
}