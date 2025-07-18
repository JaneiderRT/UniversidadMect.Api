import { useEstudiantesInscripcion } from "../hooks/useEstudiante"

export default function EstudiantesInscripcionList() {
    const { data, isLoading, error } = useEstudiantesInscripcion()

    if (isLoading) return <p>Cargando los estudiantes y sus inscripciones...</p>
    if (error) return <p>Error al cargar los estudiantes y sus inscripciones: {error.message}</p>

    const listItems = data.map((estudiante, index) => (
        <div key={`${estudiante.estudianteId}-${index}`}>
            <h2>{estudiante.nombreMateria}</h2>
            <p>Código Estudiante: {estudiante.codigo}</p>
            <p>Nombre Estudiante: {estudiante.primerNombre} {estudiante.primerApellido}</p>
            <p>Tipo De Identificación: {estudiante.tipoIdentificacion}</p>
            <p>Número De Identificación: {estudiante.identificacion}</p>
            <p>Créditos De Materia: {estudiante.creditosMateria}</p>
            <p>Nombre Profesor: {estudiante.primerNombreProfesor} {estudiante.primerApellidoProfesor}</p>
            <p>Estado: {estudiante.esActivo ? ("Activo") : ("No Activo")}</p>
        </div>
    ))

    return(
        <article>
            {listItems}
        </article>
    )
}