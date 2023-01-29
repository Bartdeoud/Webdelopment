describe('Zaal toevoegen test', () => {
    it('Checks if zaal toevoegen is reachable', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Account').click()
        cy.contains('Klik hier om een zaal toe te voegen').click()
        cy.url().should('include', '/ZaalToevoegen')
    })

    it('Check if zaal toevoegen is working', () => {
        // Test
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ZaalToevoegen')
        cy.get('#naam').type('CypressTest1')
        cy.get('#rang1').type('1')
        cy.get('#rang2').type('2')
        cy.get('#rang3').type('3')
        cy.get('#rang4').type('4')
        cy.get('#invalide').type('5')
        cy.contains('Toevoegen').click()
        cy.wait(1000) 

        // Check
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ZaalAanpassen')
        cy.reload()
        cy.wait(1000)
        cy.reload()
        cy.contains('CypressTest1 aanpassen').should('be.visible')
        
        // Cleanup
        cy.contains('CypressTest1 aanpassen').click()
        cy.url().should('include', '/ZaalChanger')
        cy.contains('Verwijderen').click()
    })

    it('Check if zaal verwijderen is working', () => {
        // Setup
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ZaalToevoegen')
        cy.get('#naam').type('CypressTest2')
        cy.get('#rang1').type('1')
        cy.get('#rang2').type('2')
        cy.get('#rang3').type('3')
        cy.get('#rang4').type('4')
        cy.get('#invalide').type('5')
        cy.contains('Toevoegen').click() 

        // Test
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ZaalAanpassen')
        cy.reload()
        cy.wait(1000)
        cy.reload()
        cy.contains('CypressTest2 aanpassen').click()
        cy.url().should('include', '/ZaalChanger')
        cy.contains('Verwijderen').click()

        // Assert
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ZaalAanpassen')
        cy.reload()
        cy.contains('CypressTest2 aanpassen').should('not.exist')
    })
})