describe('Show toevoegen test', () => {
    it('Checks if show toevoegen is reachable', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Account').click()
        cy.contains('Klik hier om een show toe te voegen').click()
        cy.url().should('include', '/ShowToevoegen')
    })

    it('Check if show toevoegen is working', () => {
        // Test
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowToevoegen')
        cy.get('#Name').type('CypressTest5')
        cy.get('#genre').select('Horror')
        cy.get('#leeftijd').select('Alle leeftijden')
        cy.get('#zaal').select('Zaal 1')
        cy.contains('Toevoegen').click()
        
        // Check
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowToevoegen')
        cy.reload()
        cy.wait(1000)
        cy.reload()
        cy.contains('CypressTest5 aanpassen').click()
        cy.url().should('include', '/ShowChanger')
        cy.get('#Name').should('have.value', 'CypressTest5')
        cy.get('#genre').should('have.value', 'Horror')
        cy.get('#leeftijd').should('have.value', 'Alle leeftijden')
        cy.get('#zaal').should('have.value', 'Zaal 1')
        
        // Cleanup
        cy.contains('Verwijderen').click()
    })

    it('Check if show verwijderen is working', () => {
        // Setup
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowToevoegen')
        cy.get('#Name').type('CypressTest6')
        cy.get('#genre').select('Horror')
        cy.get('#leeftijd').select('Alle leeftijden')
        cy.get('#zaal').select('Zaal 1')
        cy.contains('Toevoegen').click()
        
        // Test
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowToevoegen')
        cy.reload()
        cy.wait(1000)
        cy.reload()
        cy.contains('CypressTest6 aanpassen').click()
        cy.url().should('include', '/ShowChanger')
        cy.contains('Verwijderen').click()
        
        // Check
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowToevoegen')
        cy.reload()
        cy.wait(1000)
        cy.reload()
        cy.contains('CypressTest6 aanpassen').should('not.exist')
    })
})