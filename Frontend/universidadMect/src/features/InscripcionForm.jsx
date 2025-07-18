import { useState } from "react";
import { useInscripcion } from "../hooks/useInscripcion";

export default function InscripcionForm() {
    const [formData, setFormData] = useState({
        materiaId: 0,
        estudianteId: 0,
        esActivo: true
    })

    function handleSubmit(e) {
        e.preventDefault()
        createInscripcion(formData)
    }

    const { mutate: createInscripcion, isPending, error } = useInscripcion()

    return(
        <form onSubmit={handleSubmit}>
            { error && <p>Error: {error.message}</p> }
            <div>
                <label htmlFor="idMateria">
                    Id Materia:
                </label>
                <input 
                    type="number"
                    placeholder="Id De Materia"
                    id="idMateria"
                    onChange={(e) => setFormData({ ...formData, materiaId: parseInt(e.target.value) })}
                />
            </div>
            <div>
                <label htmlFor="idEstudiante">
                    Id Estudiante:
                </label>
                <input 
                    type="number"
                    placeholder="Id De Estudiante"
                    id="idEstudiante"
                    onChange={(e) => setFormData({ ...formData, estudianteId: parseInt(e.target.value) })}
                />
            </div>
            <div>
                <label htmlFor="estado">
                    Estado:
                </label>
                <input 
                    type="checkbox"
                    placeholder="Estado"
                    id="estado"
                    name="estado"
                    onChange={(e) => setFormData({ ...formData, esActivo: e.target.checked })}
                />
            </div>
            <div>
                <button type="submit" disabled={isPending}>
                    {isPending ? "Registrando..." : "Crear Inscripcion"}
                </button>
                <button type="reset">Limpiar Campos</button>
            </div>
        </form>
    )
}