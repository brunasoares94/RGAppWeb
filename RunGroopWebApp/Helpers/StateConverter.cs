namespace RunGroopWebApp.Helpers
{
    public static class StateConverter
    {
        public static string GetState(State state)
        {
            switch (state)
            {
                case State.AC:
                    return "ACRE";

                case State.AL:
                    return "AlAGOAS";

                case State.AP:
                    return "AMAPÁ";

                case State.AM:
                    return "AMAZONAS";

                case State.BA:
                    return "BAHIA";

                case State.CE:
                    return "CEARÁ";

                case State.ES:
                    return "ESPÍRITO SANTO";

                case State.GO:
                    return "GOIÁS";

                case State.MA:
                    return "MARANHÃO";

                case State.MT:
                    return "MATO GROSSO";

                case State.MS:
                    return "MATO GROSSO DO SUL";

                case State.MG:
                    return "MINAS GERAIS";

                case State.PA:
                    return "PARÁ";

                case State.PB:
                    return "PARAÍBA";

                case State.PR:
                    return "PARANÁ";

                case State.PE:
                    return "PERNAMBUCO";

                case State.PI:
                    return "PIAUÍ";

                case State.RJ:
                    return "RIO DE JANEIRO";

                case State.RN:
                    return "RIO GRANDE DO NORTE";

                case State.RS:
                    return "RIO GRANDE DO SUL";

                case State.RO:
                    return "RONDÔNIA";

                case State.RR:
                    return "RORAIMA";

                case State.SC:
                    return "SANTA CATARINA";

                case State.SP:
                    return "SÃO PAULO";

                case State.SE:
                    return "SERGIPE";

                case State.TO:
                    return "TOCANTINS";

                case State.DF:
                    return "DISTRITO FEDERAL";
            }

            throw new Exception("Não disponível");
        }

        public static State GetStateByName(string name)
        {
            switch (name.ToUpper())
            {
                case "ACRE":
                    return State.AC;

                case "ALAGOAS":
                    return State.AL;

                case "AMAPÁ":
                    return State.AP;

                case "AMAZONAS":
                    return State.AM;

                case "BAHIA":
                    return State.BA;

                case "CEARÁ":
                    return State.CE;

                case "ESPÍRITO SANTO":
                    return State.ES;

                case "GOIÁS":
                    return State.GO;

                case "MARANHÃO":
                    return State.MA;

                case "MATO GROSSO":
                    return State.MT;

                case "MATO GROSSO DO SUL":
                    return State.MS;

                case "MINAS GERAIS":
                    return State.MG;

                case "PARÁ":
                    return State.PA;

                case "PARAÍBA":
                    return State.PB;

                case "PARANÁ":
                    return State.PR;

                case "PERNAMBUCO":
                    return State.PE;

                case "PIAUÍ":
                    return State.PI;

                case "RIO DE JANEIRO":
                    return State.RJ;

                case "RIO GRANDE DO NORTE":
                    return State.RN;

                case "RIO GRANDE DO SUL":
                    return State.RS;

                case "RONDÔNIA":
                    return State.RO;

                case "RORAIMA":
                    return State.RR;

                case "SANTA CATARINA":
                    return State.SC;

                case "SÃO PAULO":
                    return State.SP;

                case "SERGIPE":
                    return State.SE;

                case "TOCANTINS":
                    return State.TO;

                case "DISTRITO FEDERAL":
                    return State.DF;
            }

            throw new Exception("Não Disponível");
        }

        public enum State
        {
            AC,
            AL,
            AP,
            AM,
            BA,
            CE,
            ES,
            GO,
            MA,
            MT,
            MS,
            MG,
            PA,
            PB,
            PR,
            PE,
            PI,
            RJ,
            RN,
            RS,
            RO,
            RR,
            SC,
            SP,
            SE,
            TO,
            DF,
        }
    }
}
