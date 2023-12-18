
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
                                <li><a href="https://www.youtube.com/watch?v=UHFha439Rt8" target="_blank"><img src="./Imagens/VAVA.JPG"/></a></li>
                                <li><a href="https://www.youtube.com/watch?v=nSE38xjMLqE" target="_blank"><img src="./Imagens/CS.JPG"/></a></li>
                                <li><a href="https://www.youtube.com/watch?v=QkkoHAzjnUs"target="_blank"><img src="./Imagens/GTA.JPG"/></a></li>
                                <li><a href="https://www.youtube.com/watch?v=vzHrjOMfHPY"target="_blank"><img src="./Imagens/LOL.JPG"/></a></li>
                                <li><a href="https://www.youtube.com/watch?v=D-VNKfmm_ho"target="_blank"><img src="./Imagens/Fortnite.JPG"/></a></li>
                                <li><a href="https://www.youtube.com/watch?v=0E44DClsX5Q"target="_blank"><img src="./Imagens/COD.JPG"/></a></li>                    
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