import { useProgramas } from "../hooks/usePrograma"

export default function ProgramaList() {
    const { data, isLoading, error } = useProgramas()

    if (isLoading) return <p>Cargando Todos Los Programas...</p>
    if (error) return <p>Error Cargando Todos Los Programas {error.message}</p>

    const listItem = data.map((programa) => (
        <div key={programa.programaId}>
            <h2>{programa.nombre}</h2>
            <p>Créditos Totales: {programa.creditosTotales}</p>
            <p>Id Universidad: {programa.universidadId}</p>
            <p>Estado: {programa.esActivo ? "Activo" : "No Activo"}</p>
        </div>
    ))

    return(
        <article>
            {listItem}
        </article>
    )
}