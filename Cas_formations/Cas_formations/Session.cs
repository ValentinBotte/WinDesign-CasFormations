/**************************************************************************
* Source File	:  Session.cs
* Author                   :  Lycée BONAPARTE
* Project name         :  Espace de travail* Created                 :  13/10/2016
* Modified   	:  13/10/2016
* Description	:  Definition of the class Session
**************************************************************************/

using System;

namespace MLO1
{
	public  class Session  				
	{
		//Inners Classifiers
		
		
		//Attributes
			
		  
		 
		 	private
		  int numero; 
		 	private
		  DateTime dateDebut; 
		 	private
		  int nbMax; 
		
		//Attributes Association
		
				public MLO1.Participant[] lesParticipants;
	
		
	
		

				
		//Operations
	

        public Session(int numero, DateTime dateDebut, int nbMax, Participant[] lesParticipants)
        {
            this.numero = numero;
            this.dateDebut = dateDebut;
            this.nbMax = nbMax;
            this.lesParticipants = lesParticipants;
        }

        ///<return>int</return>

        public  int getNumero()
        {
            return this.numero;
        }
		
			///<return>void</return>
		
			public  void ajouteParticipant( Participant unParticipant)
        {
           
        }
		
			///<return>Booléen</return>
		
			public  Booléen estPleine(); 	
		 
		

	} // End Class Session
} // End Namespace MLO1

