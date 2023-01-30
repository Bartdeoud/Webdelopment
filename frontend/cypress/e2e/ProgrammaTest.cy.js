describe('Programma test', () => {
    it ('Check if programma is reachable', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Programma').click()
        cy.url().should('include', '/Programma')
        cy.contains('Programma')
    })

    it('Check if programma is correctly displayed', () => {
        // Setup
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Admin')
        cy.get('#password').type('AdminW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')
        
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowToevoegen')
        cy.get('#Name').type('CypressTest8')
        cy.get('#genre').select('Horror')
        cy.get('#leeftijd').select('Alle leeftijden')
        cy.get('#zaal').select('Zaal 1')
        cy.contains('Show toevoegen').click()

        // Test
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Programma')
        cy.contains('CypressTest8')
        
        // Cleanup
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowAanpassen')
        cy.wait(1000)
        cy.reload()
        cy.contains('CypressTest8 aanpassen').click()
        cy.url().should('include', '/ShowChanger')
        cy.contains('Verwijderen').click()
    })
})