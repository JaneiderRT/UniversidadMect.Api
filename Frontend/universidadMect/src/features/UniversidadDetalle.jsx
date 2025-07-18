import "./UniversidadDetalle.css"
import { useUniversidad } from "../hooks/useUniversidad"

export default function UniversidadDetalle({ idUniversidad }) {

    const { data, isLoading, error } = useUniversidad(idUniversidad)

    if (isLoading) return <p>Un momento, por favor...</p>
    if (error) return <p>Se presento un error al obtener la universidad: {error.message}</p>

    return(
        <ul>
            <li> 
                <span className="title-list"> Nombre: </span> 
                { data.nombre }
            </li>
            <li> 
                <span className="title-list"> Nit: </span> 
                { data.nit }
            </li>
            <li> 
                <span className="title-list"> Codigo Verificacion: </span> 
                { data.codigoVerificacion }
            </li>
            <li> 
                <span className="title-list"> Direccion: </span> 
                { data.direccion }
            </li>
            <li> 
                <span className="title-list"> Telefono: </span> 
                { data.telefono }
            </li>
            <li> 
                <span className="title-list"> Estado: </span> 
                { data.esActivo ? ("Activo") : ("No Activo") }
            </li>
        </ul>
    )
}