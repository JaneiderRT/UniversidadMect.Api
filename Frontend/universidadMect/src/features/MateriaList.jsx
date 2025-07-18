import { useMateria } from "../hooks/useMateria"

export default function MateriaList() {
    const { data, isLoading, error } = useMateria()

    if (isLoading) return <p>Cargando materias...</p>
    if (error) return <p>Error al cargar las materias: {error.message}</p>

    const listItems = data.map((materia) => (
        <div key={materia.materiaId}>
            <h2>{materia.nombre}</h2>
            <p>Id: {materia.materiaId}</p>
            <p>Créditos: {materia.creditosMateria}</p>
            <p>Id Profesor: {materia.profesorId}</p>
            <p>Estado: {materia.esActivo ? ("Activo") : ("No Activo")}</p>
        </div>
    ))

    return(
        <article>
            {listItems}
        </article>
    )
}