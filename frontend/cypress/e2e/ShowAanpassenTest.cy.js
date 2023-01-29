describe('template spec', () => {
    it('Checks if show aanpassen is reachable', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Account').click()
        cy.contains('Klik hier om de shows aan te passen').click()
        cy.url().should('include', '/ShowAanpassen')
    })

    it('Check if show aanpassen is working', () => {
        // Setup
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowToevoegen')
        cy.get('#Name').type('CypressTest4')
        cy.get('#genre').select('Horror')
        cy.get('#leeftijd').select('Alle leeftijden')
        cy.get('#zaal').select('Zaal 1')
        cy.contains('Toevoegen').click()

        // Test
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowAanpassen')
        cy.reload()
        cy.wait(1000)
        cy.reload()
        cy.contains('CypressTest4 aanpassen').click()
        cy.url().should('include', '/ShowChanger')
        cy.get('#Name').clear().type('CypressTest4.5')
        cy.get('#genre').select('Comedy')
        cy.get('#leeftijd').select('Onder de 18')
        cy.get('#zaal').select('Zaal 2')
        cy.contains('Aanpassen').click()

        // Cleanup
        cy.reload()
        cy.wait(1000)
        cy.reload()

        cy.contains('CypressTest4.5 aanpassen').click()
        cy.url().should('include', '/ShowChanger')
        cy.get('#Name').should('have.value', 'CypressTest4.5')
        cy.get('#genre').should('have.value', 'Comedy')
        cy.get('#leeftijd').should('have.value', 'Onder de 18')
        cy.get('#zaal').should('have.value', 'Zaal 2')
        cy.contains('Verwijderen').click()
    })
})