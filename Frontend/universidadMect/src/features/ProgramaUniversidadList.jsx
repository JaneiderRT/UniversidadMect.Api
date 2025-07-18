import { useProgramasUniversidad } from "../hooks/usePrograma"

export default function ProgramaUniversidadList({ idUniversidad }) {
    const { data, isLoading, error } = useProgramasUniversidad(idUniversidad)

    if (isLoading) return <p>Cargando Los Programas De La Universidad {idUniversidad}...</p>
    if (error) return <p>Error Cargando Los Programas De La Universidad {idUniversidad} {error.message}</p>

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