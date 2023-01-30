describe('Zaal aanpassen test', () => {
    it('Checks if zaal aanpassen is reachable', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Account').click()
        cy.contains('Klik hier om een zaal aan te passen').click()
        cy.url().should('include', '/ZaalAanpassen')
    })

    it('Check if zaal aanpassen is working', () => {
        // Setup
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Admin')
        cy.get('#password').type('AdminW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')
        
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ZaalToevoegen')
        cy.get('#naam').type('CypressTest3')
        cy.get('#rang1').type('1')
        cy.get('#rang2').type('2')
        cy.get('#rang3').type('3')
        cy.get('#rang4').type('4')
        cy.get('#invalide').type('5')
        cy.contains('Toevoegen').click()

        // Test
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ZaalAanpassen')
        cy.wait(1000)
        cy.reload()
        cy.contains('CypressTest3 aanpassen').click()
        cy.url().should('include', '/ZaalChanger')
        cy.get('#naam').clear().type('CypressTest3.5')
        cy.get('#rang1').clear().type('10')
        cy.get('#rang2').clear().type('20')
        cy.get('#rang3').clear().type('30')
        cy.get('#rang4').clear().type('40')
        cy.get('#invalideplaatsen').clear().type('50')
        cy.contains('Aanpassen').click()

        cy.contains('CypressTest3.5 aanpassen').click()
        cy.url().should('include', '/ZaalChanger')
        cy.get('#naam').should('have.value', 'CypressTest3.5')
        cy.get('#rang1').should('have.value', '10')
        cy.get('#rang2').should('have.value', '20')
        cy.get('#rang3').should('have.value', '30')
        cy.get('#rang4').should('have.value', '40')
        cy.get('#invalideplaatsen').should('have.value', '50')

        // Cleanup
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ZaalAanpassen')
        cy.reload()
        cy.contains('CypressTest3.5 aanpassen').click()
        cy.url().should('include', '/ZaalChanger')
        cy.contains('Verwijderen').click()
    })
})