describe('Show toevoegen test', () => {
    it('Checks if show toevoegen is reachable', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Account').click()
        cy.contains('Klik hier om een show toe te voegen').click()
        cy.url().should('include', '/ShowToevoegen')
    })

    it('Check if show toevoegen is working', () => {
        // Setup
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Admin')
        cy.get('#password').type('AdminW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')
        
        // Test
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowToevoegen')
        cy.get('#Name').type('CypressTest5')
        cy.get('#genre').select('Horror')
        cy.get('#leeftijd').select('Alle leeftijden')
        cy.get('#zaal').select('Zaal 1')
        cy.contains('Show toevoegen').click()
        cy.wait(1000)
        
        // Check
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowAanpassen')
        cy.reload()
        cy.wait(1000)
        cy.reload()
        cy.contains('CypressTest5 aanpassen').click()
        cy.url().should('include', '/ShowChanger')
        cy.get('#NameChange').should('have.value', 'CypressTest5')
        cy.get('#genrechange').contains('Horror')
        cy.get('#leeftijdchange').contains('Alle leeftijden')
        cy.get('#zaalchange').contains('Zaal 1')
        
        // Cleanup
        cy.contains('Verwijderen').click()
    })
})