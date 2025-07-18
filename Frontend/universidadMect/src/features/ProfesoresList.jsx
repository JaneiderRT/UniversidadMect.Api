import { useProfesores } from "../hooks/useProfesor";

export default function ProfesoresList() {
    const { data, isLoading, error } = useProfesores()

    if (isLoading) return <p>Cargando listado de profesores...</p>
    if (error) return <p>Error al cargar el listado de profesores: {error.message}</p>

    const listItems = data.map((profesor) => (
        <div key={profesor.profesorId}>
            <h2>{profesor.primerNombre} {profesor.primerApellido}</h2>
            <p>Id: {profesor.profesorId}</p>
            <p>Código: {profesor.codigo}</p>
            <p>Tipo Identificación: {profesor.tipoIdentificacion}</p>
            <p>Número Identificación: {profesor.identificacion}</p>
            <p>Id Universidad: {profesor.universidadId}</p>
            <p>Estado: {profesor.esActivo ? "Activo" : "No Activo"}</p>
        </div>
    ))

    return(
        <article>
            {listItems}
        </article>
    )
}