import { useEstudiantes } from "../hooks/useEstudiante"

export default function EstudianteList() {
    const { data, isLoading, error } = useEstudiantes()

    if (isLoading) return <p>Cargando estudiantes...</p>
    if (error) return <p>Error al cargar los estudiantes: {error.message}</p>

    const listItems = data.map((estudiante) => (
        <div key={estudiante.estudianteId}>
            <h2>Estudiante {estudiante.estudianteId}</h2>
            <p>Código: {estudiante.codigo}</p>
            <p>Nombre: {estudiante.primerNombre}</p>
            <p>Apellido: {estudiante.primerApellido}</p>
            <p>Tipo De Identificación: {estudiante.tipoIdentificacion}</p>
            <p>Número De Identificación: {estudiante.identificacion}</p>
            <p>Estado: {estudiante.esActivo ? ("Activo") : ("No Activo")}</p>
        </div>
    ))

    return(
        <article>
            {listItems}
        </article>
    )
}