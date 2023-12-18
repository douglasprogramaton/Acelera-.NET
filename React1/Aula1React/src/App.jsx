import { useState } from 'react'
import './App.css'
import Cabecalho from './Cabecalho'
import Section from './Section'

export default function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <Cabecalho/>
      <Section tipo="Sobre" titulo="Sobre Mim" SubTitulo="Um apaixonado por desafios e pela evolução constante, trilhei meu caminho começando como programador e operador de centros de usinagens, dominando os comandos das máquinas como Fanuc 0Inc e Siemens. Minha jornada me levou aos tornos CNC, onde mergulhei no universo dos dissipadores de calor, desvendando os segredos da precisão e da eficiência nesse ramo. Com o tempo, encontrei uma nova paixão na área de desenvolvimento de software. Abri portas para explorar essa vertente, sedento por conhecimento e por desafios que impulsionassem meu crescimento. Atualmente, estou imerso na equipe de RPA (Automação de Processos Robóticos) da Atos do Brasil, onde presto serviços para um dos maiores parques de RPA do país, atendendo a Vivo (Telefônica). Minha jornada é moldada pela curiosidade insaciável, sempre buscando novas formas de aprender e aprimorar minhas habilidades. Enquanto embarco nessa nova fase, abraço cada oportunidade para expandir meu conhecimento e deixar minha marca no mundo da tecnologia."/>
      <Section tipo="Jogos" titulo="Jogos" SubTitulo=""/>
      <Section tipo="Contatos" titulo="Meus Contatos" SubTitulo=""/>
    </>
  )
}

