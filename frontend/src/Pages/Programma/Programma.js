import React from "react";

const Programma = () => {
    const [posts, setPosts] = useState([])
    const cookies = new Cookies(document.cookies);

    useEffect(() => {
        axios.get('https://localhost:7214/api/Show',
        {
            headers: cookies.get("Authorization"),
        })
        .then(res => {
            console.log(res)
            setPosts(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
        // eslint-disable-next-line
    }, []);

    if (posts.length === 0){
        return (
            <>
            <Hero2 tekst="Geen shows gevonden "/>
            <Alinea titel="We konden helaas geen shows vinden."
                tekst="Herlaad de pagina of probeer het later opnieuw"/>
        </>
        )
    }else {
        return (
            <div>
                <Hero2 tekst="Programma"/>
                {posts.map(voorstelling =>
                <EvenementBlock 
                    shownr={voorstelling.shownr}
                    TitelVoorstelling={voorstelling.naam}
                    zaal={"Zaal " + voorstelling.zaal}
                    datum={(voorstelling.beginTijd).substring(0,10)}
                    tijd={(voorstelling.beginTijd).substring(11,16)}
                    LinkToImg={voorstelling.afbeelding}/>
                )}
            </div>
        )
    }
}

export default Programma;