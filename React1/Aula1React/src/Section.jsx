
export default function Section(props) {
    
    switch(props.tipo){
        case "Sobre": return(
            <> 
               <section>
                        <div>
                                <h2>{props.titulo}</h2>
                                <p>{props.SubTitulo}</p> 
                        </div>
                </section>

            </>
        )
        case "Jogos": return(
            <>
                <section>
                    <div>
                        <h2>{props.titulo}</h2>
                        <p>{props.SubTitulo}</p>
                        
                        <ul class="film-list">
                                <li><a href="https://playvalorant.com/pt-br/?gad_source=1&gclid=Cj0KCQiAj_CrBhD-ARIsAIiMxT8McAf4wU5mNZCsQ6ohb-AE9I1PB1YcZKLDApGVlY8AjvoyiKSTsLgaAnU6EALw_wcB&gclsrc=aw.ds" target="_blank"><img src="./Imagens/VAVA.JPG"/></a></li>
                                <li><a href="https://store.steampowered.com/app/730/CounterStrike_2/" target="_blank"><img src="./Imagens/CS.JPG"/></a></li>
                                <li><a href="https://www.rockstargames.com/br/gta-v"target="_blank"><img src="./Imagens/GTA.JPG"/></a></li>
                                <li><a href="https://www.leagueoflegends.com/pt-br/"target="_blank"><img src="./Imagens/LOL.JPG"/></a></li>
                                <li><a href="https://www.fortnite.com/?lang=pt-BR"target="_blank"><img src="./Imagens/Fortnite.JPG"/></a></li>
                                <li><a href="https://www.callofduty.com/br/pt/warzone"target="_blank"><img src="./Imagens/COD.JPG"/></a></li>                    
                         </ul>

                    </div>
              </section>
            </>
        )
        case "Contatos": return(
            <>
            <section>
                <div>
                    <h2>{props.titulo}</h2>
                    <p>{props.SubTitulo}</p>
               
                    <ul class="film-list">
                <li><a href="https://www.linkedin.com/in/douglas-araujo-santos/" target="_blank"><img src="./Imagens/linkedin.png"
                            alt="Logo linkedin" title="Logo linkedin"/></a></li>
                <li><a href="https://github.com/douglasprogramaton" target="_blank"><img
                            src="./Imagens/git.png" alt="Logo Git" title="Logo Git"/></a></li>
               
            </ul>
                </div>
          </section>
        </>
        )
    }
}