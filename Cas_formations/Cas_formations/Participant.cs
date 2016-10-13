/**************************************************************************
* Source File	:  Participant.cs
* Author                   :  Lycée BONAPARTE
* Project name         :  Espace de travail* Created                 :  13/10/2016
* Modified   	:  13/10/2016
* Description	:  Definition of the class Participant
**************************************************************************/

using System;

namespace MLO1
{
	public  class Participant  				
	{
		//Inners Classifiers
		
		
		//Attributes
			
		  
		 
		 	private
		  string nom; 
		 	private
		  string prenom; 
		 	private
		  int anciennete; 
		
		//Attributes Association
		
				public MLO1.Session[] lesChoix;
	
		
	
		

				
		//Operations
		
		
			///<return>void</return>
		
			public  void Participant( string unNom ,  string unPrenom ,  int uneAnciennete ,  Session desChoix );
		
			///<return>void</return>
		
			public  void getChoixSession( int index );
		
			///<return>void</return>
		
			public  void setLaSession( Session uneSession ); 	
		 
		

	} // End Class Participant
} // End Namespace MLO1

