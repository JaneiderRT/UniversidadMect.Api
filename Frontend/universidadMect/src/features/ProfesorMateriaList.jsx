import { useProfesorMaterias } from "../hooks/useProfesor";

export default function ProfesorMateriaList({ idProfesor }) {
    const { data, isLoading, error } = useProfesorMaterias(idProfesor)

    if (isLoading) return <p>Cargando profesores y las materias que imparten...</p>
    if (error) return <p>Error cargando profesores y las materias que imparten : {error.message}</p>

    const listItems = data.map((profesor, index) => (
        <div key={`${profesor.profesorId}-${index}`}>
            <h2>{profesor.nombreMateria}</h2>
            <p> Profesor: {profesor.primerNombre} {profesor.primerApellido}</p>
            <p>Id Profesor: {profesor.profesorId}</p>
            <p>Id Universidad: {profesor.universidadId}</p>
            <p>Código Profesor: {profesor.codigo}</p>
            <p>Tipo Identificación: {profesor.tipoIdentificacion}</p>
            <p>Número Identificación: {profesor.identificacion}</p>
            <p>Estado: {profesor.esActivo ? ("Activo") : ("No Activo")}</p>
        </div>
    ))

    return(
        <article>
            {listItems}
        </article>
    )
}