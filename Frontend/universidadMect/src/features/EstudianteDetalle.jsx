import { useEstudiante } from "../hooks/useEstudiante"

export default function EstudianteDetalle({ idEstudiante }) {
    const { data, isLoading, error } = useEstudiante(idEstudiante);

    if (isLoading) return <p>Cargando estudiante...</p>
    if (error) return <p>Error al cargar el estudiante: {error.message}</p>

    return(
        <ul>
            <li>
                Código {data.codigo}
            </li>

            <li>
                Nombre: {data.primerNombre } {data.primerApellido}
            </li>

            <li>
                Tipo De Identificación: {data.tipoIdentificacion}
            </li>

            <li>
                Número De Identificación: {data.identificacion}
            </li>

            <li>
                Cantidad De Cŕeditos A Inscribir Del Estudiante: {data.creditosEstudiante}
            </li>

            <li>
                Estado: { data.esActivo ? ("Activo") : ("No Activo") }
            </li>
        </ul>
    )
}