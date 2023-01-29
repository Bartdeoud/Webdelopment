describe('template spec', () => {
    it('Check if account maken in reachable ', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Account').click()
        cy.contains('Klik dan hier om een account aan te maken').click()
        cy.url().should('include', '/Aanmaken')
        cy.contains('Gebruikersnaam:').should('be.visible')
        cy.contains('E-mail adres:').should('be.visible')
        cy.contains('Wachtwoord:').should('be.visible')
        cy.contains('Bevestig wachtwoord:').should('be.visible')
    })

    it('Check if gebruikersnaam validation is correct', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Aanmaken')
        cy.contains('Minimaal 8 karakters').should('be.hidden')
        cy.contains('Maximaal 100 karakters').should('be.hidden')
        cy.contains('Begint met een letter').should('be.hidden')
        
        cy.get('#username').type('test')
        cy.contains('Minimaal 8 karakters').should('be.visible')
        cy.contains('Maximaal 100 karakters').should('be.visible')
        cy.contains('Begint met een letter').should('be.visible')
        
        cy.get('#username').clear()
        cy.get('#username').type('1test')
        cy.contains('Minimaal 8 karakters').should('be.visible')

        cy.get('#username').clear()
        cy.get('#username').type('Goedwachtwoord123')
        cy.contains('Minimaal 8 karakters').should('be.hidden')
    })

    it ('Check if email validation is correct', () => {
        // cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Aanmaken')
        cy.visit('http://localhost:3000/Aanmaken')
        cy.contains('Het email adres moet een geldig email adres zijn.').should('be.visible')

        cy.get('#emailadres').type('test')
        cy.contains('Het email adres moet een geldig email adres zijn.').should('be.visible')

        cy.get('#emailadres').clear()
        cy.get('#emailadres').type('test@test')
        cy.contains('Het email adres moet een geldig email adres zijn.').should('be.hidden')
    })

    it ('Check if password validation is correct', () => {
        // cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Aanmaken')
        cy.visit('http://localhost:3000/Aanmaken')
        cy.contains('Het wachtwoord moet minimaal 7 karakaters lang zijn.').should('be.visible')

        cy.get('#password').type('fout')
        cy.contains('Het wachtwoord moet minimaal 7 karakaters lang zijn.').should('be.visible')

        cy.get('#password').clear()
        cy.get('#password').type('Foutwachtwoord123')
        cy.contains('Het wachtwoord moet minimaal 7 karakaters lang zijn.').should('be.visible')

        cy.get('#password').clear()
        cy.get('#password').type('Goedwachtwoord123!')
        cy.contains('Het wachtwoord moet minimaal 7 karakaters lang zijn.').should('be.hidden')
    })

    it ('Check if password confirmation validation is correct', () => {
        // cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Aanmaken')
        cy.visit('http://localhost:3000/Aanmaken')
        cy.contains('Wachtwoorden komen niet overeen').should('be.hidden')

        cy.get('#password').type('Goedwachtwoord123!')
        cy.get('#confirm_pwd').type('Foutwachtwoord123!')
        cy.contains('Wachtwoorden komen niet overeen').should('be.visible')

        cy.get('#confirm_pwd').clear()
        cy.get('#confirm_pwd').type('Goedwachtwoord123!')
        cy.contains('Wachtwoorden komen niet overeen').should('be.hidden')
    })

    it ('Check if account aanmaken button is working', () => {
        // cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Aanmaken')
        cy.visit('http://localhost:3000/Aanmaken')
        cy.contains('Registreer').should('be.disabled')

        cy.get('#username').type('Goedwachtwoord123')
        cy.get('#emailadres').type('test@test')
        cy.get('#password').type('Goedwachtwoord123!')
        cy.get('#confirm_pwd').type('Goedwachtwoord123!')
        cy.contains('Registreer').should('be.enabled').click()
    })
})