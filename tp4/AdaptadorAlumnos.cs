namespace tp1.tp4
{
    public class AdaptadorAlumnos : Student
    {   
        //Campos
        IComparable alumno;

        //Constructor
        public AdaptadorAlumnos(IComparable alumno){
            this.alumno = alumno;
        }

        //Metodos de la interfaz AdaptadorAlumnos

        public IComparable get_alumno()
        {
            return alumno;
        }
        public void set_alumno(IComparable alumno)
        {
            this.alumno = alumno;
        }

        //Intefaz student

        //Decorando los metodos del MDPI
        public string showResult(){
            return((IDecoradorAlumnos)alumno).mostrarCalificacion();
        }

        public string getName(){
            return((IDecoradorAlumnos)alumno).getNombre();
        }

        public bool equals(Student student){
            return alumno.sosIgual(((AdaptadorAlumnos)student).get_alumno());
        }


		public bool lessThan(Student student){
            return alumno.esMenor(((AdaptadorAlumnos)student).get_alumno());
        }
		public bool greaterThan(Student student){
            return alumno.esMayor(((AdaptadorAlumnos)student).get_alumno());
        }

        public int yourAnswerIs(int question){
            return (int)((IDecoradorAlumnos)alumno).responderPregunta(question);
        }
		public void setScore(int score){
            ((IDecoradorAlumnos)alumno).setCalificacion(score);
        }
	}


    }
