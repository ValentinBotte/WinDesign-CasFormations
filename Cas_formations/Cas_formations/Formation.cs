/**************************************************************************
* Source File	:  Formation.cs
* Author                   :  Lycée BONAPARTE
* Project name         :  Espace de travail* Created                 :  13/10/2016
* Modified   	:  13/10/2016
* Description	:  Definition of the class Formation
**************************************************************************/

using System;

namespace MLO1
{
	public  class Formation  				
	{
		//Inners Classifiers
		
		
		//Attributes
			
		  
		 
		 	private
		  string code; 
		 	private
		  string libelle; 
		 	private
		  int nbJours; 
		
		//Attributes Association
		
				public MLO1.Session[] mesSessions;
				public MLO1.Participant[] lesInscrits;
	
		
	
		

				
		//Operations
		
		
			///<return>void</return>
		
			public  void affecteParticipants(); 	
		 
		

	} // End Class Formation
} // End Namespace MLO1

