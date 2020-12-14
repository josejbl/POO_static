namespace POO_static
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.24f; 

        public static float RealParaDolar(float valorRS){ 
            return valorRS / cotacaoDolar ;
        }
        
        public static float DolarParaReais(float valorUS){ 
                return cotacaoDolar * valorUS ;
        }
    
        private static float cotacaoEuro = 6.12f; 

        public static float RealParaEuro(float valorRS){ 
            return valorRS / cotacaoEuro ;
        }
        
        public static float EuroParaReais(float valorEUR){ 
                return cotacaoDolar * valorEUR ;
        }

    }

    


    
}
