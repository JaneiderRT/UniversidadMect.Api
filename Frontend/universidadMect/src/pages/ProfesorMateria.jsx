import { useParams } from "react-router-dom";
import ProfesorMateriaList from "../features/ProfesorMateriaList";

export default function ProfesorMateria() {
    const param = useParams()

    return(
        <section>
            <h1>Listado De Materias Que imparte El Profesor {param.id}</h1>
            <ProfesorMateriaList idProfesor={param.id}/>
        </section>
    )
}