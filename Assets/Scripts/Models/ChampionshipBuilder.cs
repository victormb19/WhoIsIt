namespace WhoIsIt.Models
{
    class ChampionshipBuilder
    {
        public Championship Build()
        {
            Rider[] ridersMoto3 = new Rider[]
            {
                new Rider("Gabriel Rodrigo", 2, "AR", "Indonesian Gresini Racing Moto3", "Honda", "Barcelona"),
                new Rider("Jaume Masia", 5, "ES", "Red Bull KTM Ajo", "KTM", "Algemesi"),
                new Rider("Ryusei Yamanaka", 6, "JP", "CarXpert PruestelGP", "KTM", "Yotsukaido"),
                new Rider("Dennis Foggia", 7, "IT", "Leopard Racing", "Honda", "Rome"),
                new Rider("Sergio Garcia", 11, "ES", "Valresa GASGAS Aspar Team", "GasGas", ""),
                new Rider("Filip Salac", 12, "CZ", "Rivacold Snipers Team", "Honda", "Mlada Boleslav"),
                new Rider("Andrea Migno", 16, "IT", "Rivacold Snipers Team", "Honda", "Cattolica"),
                new Rider("John McPhee", 17, "GB", "Petronas Sprinta Racing", "Honda", "Oban"),
                new Rider("Andi Farid Izdihar", 19, "ID", "Honda Team Asia", "Honda", "Bulukumba"),
                new Rider("Lorenzo Fellon", 20, "FR", "Sic58 Squadra Corse", "Honda", "Avignon"),
                new Rider("Elia Bartolini", 22, "SM", "Team Bardahl VR46 Riders Academy", "KTM", ""),
                new Rider("Niccolò Antonelli", 23, "IT", "Avintia Esponsorama Moto3", "KTM", "Cattolica"),
                new Rider("Tatsuki Suzuki", 24, "JP", "SIC58 Squadra Corse", "Honda", "Chiba"),
                new Rider("Kaito Toba", 27, "JP", "CIP Green Power", "KTM", "Fukuoka"),
                new Rider("Izan Guevara", 28, "ES", "Valresa GASGAS Aspar Team", "GasGas", "Palma de Mallorca"),
                new Rider("Adrian Fernandez", 31, "ES", "Sterilgarda Max Racing Team", "Husqvarna", "Madrid"),
                new Rider("Takuma Matsuyama", 32, "JP", "Honda Team Asia", "Honda", ""),
                new Rider("Pedro Acosta", 37, "ES", "Red Bull KTM Ajo", "KTM", "Mazarrón"),
                new Rider("Darryn Binder", 40, "ZA", "Petronas Sprinta Racing", "Honda", "Potchefstroom"),
                new Rider("Xavier Artigas", 43, "ES", "Leopard Racing", "Honda", "Barcelona"),
                new Rider("Jeremy Alcoba", 52, "ES", "Indonesian Gresini Racing Moto3", "Honda", "Tortosa"),
                new Rider("Deniz Öncü", 53, "TR", "Red Bull KTM Tech 3", "KTM", "Alanya"),
                new Rider("Riccardo Rossi", 54, "IT", "BOE Owlride", "KTM", "Genova"),
                new Rider("Romano Fenati", 55, "IT", "Sterilgarda Max Racing Team", "Husqvarna", "Ascoli Piceno"),
                new Rider("Alberto Surra", 67, "IT", "Team Bardahl VR46 Riders Academy", "KTM", "Torino"),
                new Rider("Ayumu Sasaki", 71, "JP", "Red Bull KTM Tech 3", "KTM", "Yokosuka"),
                new Rider("Maximilian Kofler", 73, "AT", "CIP Green Power", "KTM", "Voecklabruck"),
                new Rider("Stefano Nepa", 82, "IT", "BOE Owlride", "KTM", "Giulianova"),
                new Rider("Yuki Kunii", 92, "JP", "Honda Team Asia", "Honda", "Tokyo"),
                new Rider("Carlos Tatay", 99, "ES", "Avintia Esponsorama Moto3", "KTM", "Valencia"),
            };
            Category moto3 = new Category(CategoryName.Moto3, ridersMoto3);

            Rider[] ridersMoto2 = new Rider[]
            {
                new Rider("Yari Montella", 5, "IT", "Lightech Speed Up", "Boscoscuro", "Oliveto"),
                new Rider("Cameron Beaubier", 6, "US", "American Racing", "Kalex", "Rosevile"),
                new Rider("Lorenzo Baldassarri", 7, "IT", "MV Agusta Forward Racing", "MV Agusta", "San Severino Marche"),
                new Rider("Jorge Navarro", 9, "ES", "MB Conveyors Speed Up", "Boscoscuro", "La Puebla de Vallbona"),
                new Rider("Tommaso Marcon", 10, "IT", "MV Agusta Forward Racing", "MV Agusta", "Cittadella"),
                new Rider("Nicolo Bulega", 11, "IT", "Federal Oil Gresini Moto2", "Kalex", "Montecchio Emilia"),
                new Rider("Thomas Lüthi", 12, "CH", "Pertamina Mandalika SAG Team", "Kalex", "Oberdiessbach"),
                new Rider("Celestino Vietti", 13, "IT", "SKY Racing Team VR46", "Kalex", "Cirie"),
                new Rider("Tony Arbolino", 14, "IT", "Liqui Moly Intact GP", "Kalex", "Garbagnate Milanese"),
                new Rider("Joe Roberts", 16, "US", "Italtrans Racing Team", "Kalex", "Malibu"),
                new Rider("Lorenzo Dalla Porta", 19, "IT", "Italtrans Racing Team", "Kalex", "Prato"),
                new Rider("Fabio Di Giannantonio", 21, "IT", "Federal Oil Gresini Moto2", "Kalex", "Roma"),
                new Rider("Sam Lowes", 22, "GB", "ELF Marc VDS Racing Team", "Kalex", "Lincoln"),
                new Rider("Marcel Schrotter", 23, "DE", "Liqui Moly Intact GP", "Kalex", "Landsberg"),
                new Rider("Simone Corsi", 24, "IT", "MV Agusta Forward Racing", "MV Agusta", "Roma"),
                new Rider("Raul Fernandez", 25, "ES", "Red Bull KTM Ajo", "Kalex", "Madrid"),
                new Rider("Somkiat Chantra", 35, "TH", "IDEMITSU Honda Team Asia", "Kalex", "Chombury"),
                new Rider("Augusto Fernandez", 37, "ES", "ELF Marc VDS Racing Team", "Kalex", "Madrid"),
                new Rider("Hector Garzo", 40, "ES", "Flexbox HP40", "Kalex", "Valencia"),
                new Rider("Marcos Ramirez", 42, "ES", "American Racing", "Kalex", "Conil de la Frontera"),
                new Rider("Aron Canet", 44, "ES", "Kipin Energy Aspar Team", "Boscoscuro", "Corbera"),
                new Rider("Fermín Aldeguer", 54, "ES", "MB Conveyors Speed Up", "Boscoscuro", "Murcia"),
                new Rider("Hafizh Syahrin", 55, "MY", "NTS RW Racing GP", "NTS", "Ampang"),
                new Rider("Stefano Manzi", 62, "IT", "Flexbox HP40", "Kalex", "Rimini"),
                new Rider("Bo Bendsneyder", 64, "NL", "Pertamina Mandalika SAG Team", "Kalex", "Rotterdam"),
                new Rider("Barry Baltus", 70, "BE", "NTS RW Racing GP", "NTS", "Namur"),
                new Rider("Marco Bezzecchi", 72, "IT", "SKY Racing Team VR46", "Kalex", "Rimini"),
                new Rider("Albert Arenas", 75, "ES", "Kipin Energy Aspar Team", "Boscoscuro", "Girona"),
                new Rider("Ai Ogura", 79, "JP", "Idemitsu Honda Team Asia", "Kalex", "Tokyo"),
                new Rider("Remy Gardner", 87, "AU", "Red Bull KTM Ajo", "Kalex", "Sydney"),
                new Rider("Jake Dixon", 96, "GB", "Petronas Sprinta Racing", "Kalex", "Dover"),
                new Rider("Xavi Vierge", 97, "ES", "Petronas Sprinta Racing", "Kalex", "Barcelona"),
            };

            Category moto2 = new Category(CategoryName.Moto2, ridersMoto2);

            Rider[] ridersMotoGP = new Rider[]
{
                new Rider("Johann Zarco", 5, "FR", "Pramac Racing", "Ducati", "Cannes"),
                new Rider("Danilo Petrucci", 9, "IT", "Tech3 KTM Factory Racing", "KTM", "Terni"), 
                new Rider("Luca Marini", 10, "IT", "Sky VR46 Avintia", "Ducati", "Urbino"),
                new Rider("Maverick Viñales", 12, "ES", "Monster Energy Yamaha MotoGP", "Yamaha", "Figueres"),
                new Rider("Fabio Quartararo", 20, "FR", "Monster Energy Yamaha MotoGP", "Yamaha", "Nice"),
                new Rider("Franco Morbidelli", 21, "IT", "Petronas Yamaha SRT", "Yamaha", "Rome"),
                new Rider("Enea Bastianini", 23, "IT", "Avintia Esponsorama", "Ducati", "Rome"),
                new Rider("Iker Lecuona", 27, "ES", "Tech3 KTM Factory Racing", "KTM", "Valencia"),
                new Rider("Takaaki Nakagami", 27, "JP", "LCR Honda IDEMITSU", "Honda", "Chiba"),
                new Rider("Lorenzo Savadori", 32, "IT", "Aprilia Racing Team Gresini", "Aprilia", "Cesena"),
                new Rider("Brad Binder", 33, "ZA", "Red Bull KTM Factory Racing", "KTM", "Potchefstroom"),
                new Rider("Joan Mir", 36, "ES", "Team SUZUKI ECSTAR", "Suzuki", "Palma de Mallorca"),
                new Rider("Aleix Espargaro", 41, "ES", "Aprilia Racing Team Gresini", "Aprilia", "Granollers"),
                new Rider("Alex Rins", 42, "ES", "Team SUZUKI ECSTAR", "Suzuki", "Barcelona"),
                new Rider("Jack Miller", 43, "AU", "Ducati Lenovo Team", "Ducati", "Townsville"),
                new Rider("Pol Espargaro", 44, "ES", "Repsol Honda Team", "Honda", "Granollers"),
                new Rider("Valentino Rossi", 46, "IT", "Petronas Yamaha SRT", "Yamaha", "Urbino"),
                new Rider("Michele Pirro", 51, "IT", "Pramac Racing", "Ducati", "San Giovanni Rotondo"),
                new Rider("Francesco Bagnaia", 63, "IT", "Ducati Lenovo Team", "Ducati", "Torino"),
                new Rider("Alex Marquez", 73, "ES", "LCR Honda Castrol", "Honda", "Cervera"),
                new Rider("Miguel Oliveira", 88, "PT", "Red Bull KTM Factory Racing", "KTM", "Pragal"),
                new Rider("Jorge Martin", 89, "ES", "Pramac Racing", "Ducati", "Madrid"),
                new Rider("Marc Marquez", 93, "ES", "Honda", "Honda", "Cervera"),

};
            Category motoGp = new Category(CategoryName.MotoGP, ridersMotoGP);


            Rider[] ridersMotoE = new Rider[]
{
                new Rider("Lukas Tulovic", 3, "DE", "Tech 3 E-Racing", "Energica", "Eberbach"),
                new Rider("Maria Herrera", 6, "ES", "Openbank Aspar Team", "Energica", "Oropesa"),
                new Rider("Andrea Mantovani", 9, "IT", "Indonesian E-Racing Gresini MotoE", "Energica", "Ferrara"),
                new Rider("Matteo Ferrari", 11, "IT", "Indonesian E-Racing Gresini MotoE", "Energica", "Cesena"),
                new Rider("Xavier Cardelus", 18, "AD", "Avintia Esponsorama Racing", "Energica", "Andorra la Vella"),
                new Rider("Corentin Perolari", 19, "FR", "Tech 3 E-Racing", "Energica", "Pont St Esprit"),
                new Rider("Kevin Zannoni", 21, "IT", "LCR E-Team", "Energica", "Cesena"),
                new Rider("Mattia Casadei", 27, "IT", "Ongetta SIC58 Squadracorse", "Energica", ""),
                new Rider("Jordi Torres", 40, "ES", "Pons Racing 40", "Kalex", "Rubí"),
                new Rider("Eric Granado", 51, "BR", "One Energy Racing", "Energica", "Sao Paulo"),
                new Rider("Fermín Aldeguer", 54, "IT", "Openbank Aspar Team", "Energica", "Murcia"),
                new Rider("Alessandro Zaccone", 61, "IT", "OCTO Pramac MotoE", "Energica", "Rimini"),
                new Rider("Yonny Hernandez", 68, "CO", "OCTO Pramac MotoE", "Energica", "Medellín"),
                new Rider("Miquel Pons", 71, "ES", "LCR E-Team", "Energica", "Palma de Mallorca"),
                new Rider("Dominique Aegerter", 77, "CH", "Dynavolt Intact GP", "Energica", "Rohrbach"),
                new Rider("Hikari Okubo", 78, "JP", "Avant Ajo MotoE", "Energica", "Kodaira"),
                new Rider("Jasper Iwema", 80, "NL", "Pons Racing 40", "Energica", "Assen"),

};
            Category motoE = new Category(CategoryName.MotoE, ridersMotoE);

            return new Championship(new Category[4] {motoGp, moto2, moto3, motoE });
        }
    }
}
