using System;

namespace Hotel
{
	
    class Hotel
	{
		
        static void Main (string[] args)
		{
			
            Random ran = new Random();
			
            //Initialiser les variables et la liste
            int i;
            string choix; // Tu peux tout aussi bien faire en sorte que ton choix soit une variable char comme on utiliser une lettre
            int taille = 21;
            int complet = 0; // Il doit être à 0 mais tu peux le mettre à 20 pour que l'hotel soit complet 
			int pieceReserve = 0;
			int dernierReserver = 0;
			int pieceLibre = 0;
			int nombreLibre = 0;
			int numPiece = 0;
			string login = "anne";
			string mdp = "1234";
			string loginUtilisateur = null;
			string mdpUtilisateur = null;
			
			
			
            int[] piece = new int[taille];
            for (i = 1; i < piece.Length; i++) 
            {
                piece[i] = ran.Next (0, 2);
               Console.WriteLine($"piece[{i}] = {piece[i]}");
			}
			
            //Afficher le menu en boucle
            while (true)
			{

				
                Console.WriteLine("-------------------------MENU HOTEL MS DOTNET------------------------------");
				
                Console.WriteLine("\n\tA/ Afficher l'état de l'hôtel");
                Console.WriteLine("\tB/ Afficher le nombre de chambres réservées");
                Console.WriteLine("\tC/ Afficher le nombre de chambres libres");
                Console.WriteLine("\tD/ Afficher le numéro de la première chambre vide");
                Console.WriteLine("\tE/ Afficher le numéro de la dernière chambre vide");
                Console.WriteLine("\tF/ Réserver une chambre (Le programme doit réserver la première chambre vide)");
                Console.WriteLine("\tG/ Libérer une chambre (Le programme doit libérer la dernière chambre occupée)\n");
                Console.WriteLine("\tQ/ Quitter\n");
				
				Console.WriteLine("--------------------------------------------------------------------------");
				
                Console.Write("\n\tFaite votre choix: ");
                choix = Console.ReadLine(); // Il faudra du coup rentrer un seul caractère
   
				
				
				
				
                if (choix.Equals("A", System.StringComparison.OrdinalIgnoreCase))
				{
                    for (i = 1 ; i < piece.Length ; i++)
					{ 
                        complet = complet + piece[i];
					}
                    if(complet == 20)
					{
                        Console.WriteLine("\n\t- Hotel complet\n");
					}
                    else
					{
                        Console.WriteLine("\n\t- Hotel dispo\n");
					}
				}
				if (choix.Equals("B", System.StringComparison.OrdinalIgnoreCase))
				{
					pieceReserve = 0;
					
					for(i = 1; i <piece.Length; i++)
					{
						if (piece[i] == 1)
						{
							pieceReserve = pieceReserve + 1;
							
						}
						
					}
					Console.WriteLine("\n\t- Il y a " + pieceReserve + " chambre(s) reservées\n");
					
					
					
					
				}
				
				if (choix.Equals("C", System.StringComparison.OrdinalIgnoreCase))
				{
					pieceLibre = 0;
					
					for(i = 1; i< piece.Length; i++)
					{
						if(piece[i] == 0)
						{
							pieceLibre = pieceLibre + 1;
						}
						
					}
					Console.WriteLine("\n\t- Il y a " + pieceLibre + " chambre(s) libres\n");
					
				}
				
				if (choix.Equals("D", System.StringComparison.OrdinalIgnoreCase))
				{
					pieceLibre = 0;
					
					for(i = 1; i< piece.Length; i++)
					{
						if(piece[i] == 0)
						{
							
							Console.WriteLine("\n\t- La chambre " + i + " est libre\n");
							pieceLibre = pieceLibre + 1;
							break;
							
						}
						
					}
					if (pieceLibre == 0){
						Console.WriteLine("\n\t- Dsl plus de chambres libres\n");
					}
					
					
				}
				
				if(choix.Equals("E", System.StringComparison.OrdinalIgnoreCase))
				{
						
				
					nombreLibre = 0;
					numPiece = 0;
					pieceLibre = 0;
					
					for(i=1;i<piece.Length;i++)
					{
						if(piece[i] == 0 )
						{
							nombreLibre = nombreLibre + 1;
							numPiece = i;
						
							
						}
					}Console.WriteLine("\n\t- La dernière chambre vide est la " + numPiece + "\n");
					if (nombreLibre == 0)
					{
						Console.Write("\n\t- Aucunes chambres vides\n");
					}
				}
				
				
				
				if (choix.Equals("F", System.StringComparison.OrdinalIgnoreCase)) 
				{
					Console.Write("\n\tVeuillez saisir le login: ");
					loginUtilisateur = Console.ReadLine();
					Console.Write("\tVeuillez saisir le mot de passe: ");
					mdpUtilisateur = Console.ReadLine();
					if ( login == loginUtilisateur && mdp == mdpUtilisateur)
					{
							
						pieceLibre = 0;
						
						for(i = 1; i< piece.Length; i++)
						{
							if(piece[i] == 0)
							{
								piece[i] = 1;
								Console.WriteLine("\n\t- La chambre " + i + " est réservée\n");
								pieceLibre = pieceLibre + 1;
								break;
							}
							
						}
						if (pieceLibre == 0){
							Console.WriteLine("\n\t- Dsl plus de chambres libres\n");
						}
						
						
			
						
					}
					else
					{
						Console.Write("\n\t- Mot de passe ou login incorrect \n");
						
					}
						
						
				}
				if (choix.Equals("G", System.StringComparison.OrdinalIgnoreCase)) 
				{
					Console.Write("\n\tVeuillez saisir le login: ");
					loginUtilisateur = Console.ReadLine();
					Console.Write("\tVeuillez saisir le mot de passe: ");
					mdpUtilisateur = Console.ReadLine();
						
					if ( login == loginUtilisateur && mdp == mdpUtilisateur)
					{
						dernierReserver = 0;
						numPiece = 0;
						pieceLibre = 0;
						
						for(i=1;i<piece.Length;i++)
						{
							if(piece[i] == 1 )
							{
								dernierReserver = dernierReserver + 1;
								numPiece = i;
							}
						}Console.WriteLine("\n\t- La dernière chambre " + numPiece + " a été libérée \n");
						if (dernierReserver == 0)
						{
							Console.WriteLine("\n- Aucunes chambres réservées\n");
						}
					}	
					else{
						Console.WriteLine("\n- Mot de passe ou login incorrect\n");
					}
				
				}
				
				if (choix.Equals("Q", System.StringComparison.OrdinalIgnoreCase))
				{
					Console.Write("\nCordialement !\n");
					break;
				}
				
			}	
		}
		
	}
}


