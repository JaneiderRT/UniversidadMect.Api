import { useState } from "react"
import { usePutEstudiante } from "../hooks/useEstudiante"

export default function ActualizarEstudiante() {
    const [estudiante, setEstudiante] = useState({
        estudianteId: 0,
        personaId: 0,
        universidadId: 0,
        codigo: "",
        creditosEstudiante: 0,
        esActivo: true
    })

    const handleSubmit = (event) => {
        event.preventDefault();
        actualizarEstudiante(estudiante);
    }

    const { mutateAsync: actualizarEstudiante, isPending, error } = usePutEstudiante()

    return(
        <form onSubmit={handleSubmit}>
            {error && <p>Error: {error.message}</p>}
            <input
                type="number"
                placeholder="Id Del Estudiante"
                value={estudiante.estudianteId}
                onChange={(e) => setEstudiante({ ...estudiante, estudianteId: parseInt(e.target.value) })}
            />
            <input
                type="number"
                placeholder="Id Del Tipo De Persona"
                value={estudiante.personaId}
                onChange={(e) => setEstudiante({ ...estudiante, personaId: parseInt(e.target.value) })}
            />
            <input
                type="number"
                placeholder="Id De La Universidad"
                value={estudiante.universidadId}
                onChange={(e) => setEstudiante({ ...estudiante, universidadId: parseInt(e.target.value) })}
            />
            <input
                type="text"
                placeholder="Código"
                value={estudiante.codigo}
                onChange={(e) => setEstudiante({ ...estudiante, codigo: e.target.value })}
            />
            <input
                type="number"
                placeholder="Creditos Del Estudiante"
                value={estudiante.creditosEstudiante}
                onChange={(e) => setEstudiante({ ...estudiante, creditosEstudiante: parseInt(e.target.value) })}
            />
            <label>
                Estado Estudiante:
                <input
                    type="checkbox"
                    name="esActivo"
                    checked={estudiante.esActivo}
                    onChange={(e) => setEstudiante({ ...estudiante, esActivo: e.target.checked })}
                />
            </label>
            <button type="submit" disabled={isPending}>
                {isPending ? "Actualizando..." : "Actualizar Estudiante"}
            </button>
        </form>
    )
}