import {BrowserRouter as Router, Routes, Route} from "react-router-dom"
import Home from "./pages/Home.jsx"
import Universidad from "./pages/Universidad"
import Estudiante from "./pages/Estudiante"
import Estudiantes from "./pages/Estudiantes"
import EstudianteInscripcion from "./pages/EstudianteInscripcion"
import EstudiantesInscripcion from "./pages/EstudiantesInscripcion"
import EstudianteUpdate from "./pages/EstudianteUpdate"
import Inscripcion from "./pages/Inscripcion"
import Materia from "./pages/Materia"
import ProfesorMateria from "./pages/ProfesorMateria"
import Profesores from "./pages/Profesores"
import Programa from "./pages/Programa"
import ProgramaUniversidad from "./pages/ProgramaUniversidad"

export default function App() {
    return (
        <Router>
            <Routes>
                <Route path="/" element={<Home />} />
                <Route path="/universidad/:id" element={<Universidad />} />
                <Route path="/estudiantes" element={<Estudiantes />} />
                <Route path="/estudiante/:id" element={<Estudiante />} />
                <Route path="/estudiante/update" element={<EstudianteUpdate />} />
                <Route path="/inscripcion/estudiante/:id" element={<EstudianteInscripcion />} />
                <Route path="/inscripcion/estudiantes" element={<EstudiantesInscripcion />} />
                <Route path="/inscripcion/create" element={<Inscripcion />} />
                <Route path="/materias" element={<Materia />} />
                <Route path="/profesor/:id" element={<ProfesorMateria />} />
                <Route path="/profesores" element={<Profesores />}/>
                <Route path="/programas" element={<Programa />}/>
                <Route path="/programas/universidad/:id" element={<ProgramaUniversidad />}/>
            </Routes>
        </Router>
    )
}