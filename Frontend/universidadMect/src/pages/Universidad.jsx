import { useParams } from "react-router-dom"
import UniversidadDetalle from "../features/UniversidadDetalle"

export default function Universidad() {
    const params = useParams()

    return(
        <article>
            <h1>Universidad {params.id}</h1>
            <UniversidadDetalle idUniversidad={params.id}/>
        </article>
    )
}