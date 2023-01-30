describe('Show toevoegen test', () => {
    it('Checks if show aanpassen is reachable', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Account').click()
        cy.contains('Klik hier om de shows aan te passen').click()
        cy.url().should('include', '/ShowAanpassen')
    })

    it('Check if show aanpassen is working', () => {
        // Setup
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Admin')
        cy.get('#password').type('AdminW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')

        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowToevoegen')
        cy.get('#Name').type('CypressTest4')
        cy.get('#genre').select('Horror')
        cy.get('#leeftijd').select('Alle leeftijden')
        cy.get('#zaal').select('Zaal 1')
        cy.contains('Show toevoegen').click()

        // Test
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowAanpassen')
        cy.wait(1000)
        cy.reload()
        cy.contains('CypressTest4 aanpassen').click()
        cy.url().should('include', '/ShowChanger')
        cy.get('#NameChange').clear().type('CypressTest4.5')
        cy.get('#genrechange').select('Comedy')
        cy.get('#leeftijdchange').select('Onder de 18')
        cy.get('#zaalchange').select('Zaal 2')
        cy.contains('Aanpassen').click()

        // Cleanup
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ShowAanpassen')
        cy.reload()
        cy.wait(1000)
        cy.reload()

        cy.contains('CypressTest4.5 aanpassen').click()
        cy.url().should('include', '/ShowChanger')
        cy.get('#NameChange').should('have.value', 'CypressTest4.5')
        cy.get('#genrechange').contains('Comedy')
        cy.get('#leeftijdchange').contains('Onder de 18')
        cy.get('#zaalchange').contains('Zaal 2')
        cy.contains('Verwijderen').click()
    })
})