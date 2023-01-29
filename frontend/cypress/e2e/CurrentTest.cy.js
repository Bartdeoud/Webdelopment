describe('Current test', () => {
    it('Check if show verwijderen is working', () => {
        // Setup
        // cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowToevoegen')
        cy.visit('http://localhost:3000/ShowToevoegen')
        cy.get('#Name').type('CypressTest6')
        cy.get('#genre').select('Horror')
        cy.get('#leeftijd').select('Alle leeftijden')
        cy.get('#zaal').select('Zaal 1')
        cy.contains('Show toevoegen').click()
        
        // Test
        // cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowToevoegen')
        cy.visit('http://localhost:3000/ShowAanpassen')
        cy.reload()
        cy.wait(1000)
        cy.reload()
        cy.contains('CypressTest6 aanpassen').click()
        cy.url().should('include', '/ShowChanger')
        cy.contains('Verwijderen').click()
        
        // Check
        // cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowAanpassen')
        cy.visit('http://localhost:3000/ShowAanpassen')
        cy.reload()
        cy.wait(1000)
        cy.reload()
        cy.contains('CypressTest6 aanpassen').should('not.exist')
    })
})