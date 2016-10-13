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
		  Date dateDebut; 
		 	private
		  int nbMax; 
		
		//Attributes Association
		
				public MLO1.Participant[] lesParticipants;
	
		
	
		

				
		//Operations
		
		
			///<return>void</return>
		
			public  void init( int unNumero ,  Date uneDate ,  int unNb );
		
			///<return>int</return>
		
			public  int getNumero();
		
			///<return>void</return>
		
			public  void ajouteParticipant( Participant unParticipant );
		
			///<return>Booléen</return>
		
			public  Booléen estPleine(); 	
		 
		

	} // End Class Session
} // End Namespace MLO1

